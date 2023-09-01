import React from 'react';
import Card from './Card';
import '../style/cards.css'
const Main = ({ users }) => {
  return (
    <div className='cards'>
      {users.map(user => (
        <Card key={user.id} card={user} />
      ))}
    </div>
  );
};

export default Main;
