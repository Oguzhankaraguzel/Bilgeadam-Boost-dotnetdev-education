import React from 'react';
import '../style/card.css'

const Card = ({ card }) => {
  const { imgSrc, name, age, hobbies } = card;

  return (
    <div className="card" style={{ width: "18rem" }}>
      <img src={imgSrc} className="card-img-top" alt={name} />
      <div className="card-body">
        <h5 className="card-title">{name}</h5>
        <p className="card-text">{`Age: ${age}`}</p>
        <p className="card-text">{`Hobbies: ${hobbies}`}</p>
        <a href="#" className="btn btn-outline-secondary">Message</a>
      </div>
    </div>
  );
};

export default Card;
