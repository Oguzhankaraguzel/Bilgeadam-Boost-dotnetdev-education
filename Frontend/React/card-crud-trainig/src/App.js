import React, { useState } from 'react';
import Header from './components/Header';
import Main from './components/Main';
import Footer from './components/Footer';
import usersData from './data/users';
import AddCard from './components/AddCard';

function App() {
  const [users, setUsers] = useState(usersData);

  const handleCardAdd = (newCard) => {
    setUsers((prevUsers) => [...prevUsers, newCard]);
  };

  return (
    <div className="App">
      <Header />
      <AddCard onCardAdd={handleCardAdd} />
      <Main users={users} />
      <Footer />
    </div>
  );
}

export default App;
