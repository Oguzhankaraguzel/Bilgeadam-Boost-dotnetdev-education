import React, { useEffect, useState } from "react";
import "./App.css";
import { fetchFilms } from "./api";
import Card from "./Card";

const App = () => {
  const [films, setFilms] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState("Tümü");

  useEffect(() => {
    fetchFilms().then((data) => setFilms(data));
  }, []);

  const categories = ["Tümü", "Aksiyon", "Drama", "Komedi"];

  const handleCategoryChange = (category) => {
    setSelectedCategory(category);
  };

  const filteredFilms =
    selectedCategory === "Tümü"
      ? films
      : films.filter((film) => film.category === selectedCategory);

  return (
    <div className="app">
      <h1>Filmler Projesi</h1>
      <div className="categories">
        {categories.map((category) => (
          <button key={category} onClick={() => handleCategoryChange(category)}>
            {category}
          </button>
        ))}
      </div>
      <div className="films">
        {filteredFilms.map((film) => (
          <Card key={film.id} film={film} />
        ))}
      </div>
    </div>
  );
};

export default App;
