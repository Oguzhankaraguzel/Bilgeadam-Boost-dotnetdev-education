import React, { useState } from 'react';
import './App.css';
import Notes from './components/Notes';
import AddNote from './components/AddNote';
import EditNote from './components/EditNote';

const App = () => {
  const [notes, setNotes] = useState([]);
  const [editNote, setEditNote] = useState("");

  const addNote = (text) => {
    setNotes([...notes, { id: Date.now(), text }]);
  };

  const deleteNote = (id) => {
    const updatedNotes = notes.filter((note) => note.id !== id);
    setNotes(updatedNotes);
  };

  const startEditing = (note) => {
    setEditNote(note);
  };

  const updateNote = (id, text) => {
    const updatedNotes = notes.map((note) =>
      note.id === id ? { ...note, text } : note
    );
    setNotes(updatedNotes);
    setEditNote("");
  };

  return (
    <div className="app">
      <h1>Notes App</h1>
      <div className="note-section">
        <Notes
          notes={notes}
          onDelete={deleteNote}
          onStartEditing={startEditing}
        />
        <AddNote onAdd={addNote} />
      </div>
      {editNote && (
        <EditNote
          note={editNote}
          onUpdate={updateNote}
          onCancel={() => setEditNote("")}
        />
      )}
    </div>
  );
};

export default App;
