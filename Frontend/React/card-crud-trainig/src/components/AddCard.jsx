import React, { useState } from 'react';

const AddCard = ({ onCardAdd }) => {
  const [imgSrc, setImgSrc] = useState('');
  const [name, setName] = useState('');
  const [age, setAge] = useState('');
  const [hobbies, setHobbies] = useState('');

  const handleImgSrcChange = (event) => {
    setImgSrc(event.target.value);
  };

  const handleNameChange = (event) => {
    setName(event.target.value);
  };

  const handleAgeChange = (event) => {
    setAge(event.target.value);
  };

  const handleHobbiesChange = (event) => {
    setHobbies(event.target.value);
  };

  const handleFormSubmit = (event) => {
    event.preventDefault();
    const newCard = {
      imgSrc,
      name,
      age,
      hobbies
    };
    onCardAdd(newCard);
    setImgSrc('');
    setName('');
    setAge('');
    setHobbies('');
  };

  return (
    <div className="container mt-4">
      <h3 className="text-center mb-4">Add a Card</h3>
      <form onSubmit={handleFormSubmit}>
        <div className="mb-3">
          <label htmlFor="imgSrc" className="form-label">Image URL:</label>
          <input
            type="text"
            className="form-control"
            id="imgSrc"
            value={imgSrc}
            onChange={handleImgSrcChange}
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="name" className="form-label">Name:</label>
          <input
            type="text"
            className="form-control"
            id="name"
            value={name}
            onChange={handleNameChange}
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="age" className="form-label">Age:</label>
          <input
            type="text"
            className="form-control"
            id="age"
            value={age}
            onChange={handleAgeChange}
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="hobbies" className="form-label">Hobbies:</label>
          <input
            type="text"
            className="form-control"
            id="hobbies"
            value={hobbies}
            onChange={handleHobbiesChange}
            required
          />
        </div>
        <button type="submit" className="btn btn-outline-success">Add</button>
      </form>
    </div>
  );
};

export default AddCard;
