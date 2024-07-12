import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import UserList from './components/UserList'

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <h1>User Management</h1>
                <UserList />
            </header>
        </div>
    );
}

export default App
