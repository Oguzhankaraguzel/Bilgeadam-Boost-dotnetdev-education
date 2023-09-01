import axios from 'axios';

const API_BASE_URL = 'http://localhost:3001';

export const fetchFilms = async () => {
  try {
    const response = await axios.get(`${API_BASE_URL}/films`);
    return response.data;
  } catch (error) {
    console.error('Filmler alınırken bir hata oluştu:', error);
    return [];
  }
};
