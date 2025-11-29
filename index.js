const express = require('express');
const fs = require('fs').promises;
const bcrypt = require('bcrypt');
const app = express();
const port = 3000;

const USERS_FILE = './users.json';

app.use(express.json());

// Aszinkron segédfüggvény a fájl betöltéséhez
async function loadUsers() {
    try {
        await fs.access(USERS_FILE);
    } catch {
        // Ha nincs fájl, üres tömböt adunk vissza
        return [];
    }
    try {
        const data = await fs.readFile(USERS_FILE, 'utf-8');
        return JSON.parse(data);
    } catch (error) {
        console.error('Hiba a users.json betöltésekor:', error);
        return [];
    }
}

// Aszinkron segédfüggvény a fájl mentéséhez
async function saveUsers(users) {
    try {
        await fs.writeFile(USERS_FILE, JSON.stringify(users, null, 2));
    } catch (error) {
        console.error('Hiba a users.json mentésekor:', error);
    }
}

// Regisztrációs végpont
app.post('/register', async (req, res) => {
    const { username, password } = req.body;

    if (!username || !password) {
        return res.status(400).json({ message: 'Hiányzó felhasználónév vagy jelszó' });
    }

    const users = await loadUsers();

    if (users.find(u => u.username === username)) {
        return res.status(409).json({ message: 'A felhasználónév már létezik' });
    }

    const hashedPassword = await bcrypt.hash(password, 10);

    users.push({ username, passwordHash: hashedPassword });
    await saveUsers(users);

    res.json({ message: 'Sikeres regisztráció!' });
});

// Bejelentkezési végpont
app.post('/login', async (req, res) => {
    const { username, password } = req.body;

    if (!username || !password) {
        return res.status(400).json({ message: 'Hiányzó felhasználónév vagy jelszó' });
    }

    const users = await loadUsers();
    const user = users.find(u => u.username === username);

    if (!user) {
        return res.status(401).json({ message: 'Hibás felhasználónév vagy jelszó.' });
    }

    const passwordMatch = await bcrypt.compare(password, user.passwordHash);

    if (!passwordMatch) {
        return res.status(401).json({ message: 'Hibás felhasználónév vagy jelszó.' });
    }

    // Ha ide eljutunk, sikeres bejelentkezés
    res.json({ message: 'Sikeres bejelentkezés!' });
});

app.listen(port, () => {
    console.log(`Szerver fut: http://localhost:${port}`);
});

