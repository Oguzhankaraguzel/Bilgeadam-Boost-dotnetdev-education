import React from 'react'
import './css/header.css';

const Header = () => {
  return (
    <div className='header'>
        <a href="#">Home</a>
        <a href="#About">About</a>
        <a href="#Skills">Skills</a>
        <a href="#Projects">Projects</a>
        <a href="#Contact">Contact</a>
    </div>
  )
}

export default Header