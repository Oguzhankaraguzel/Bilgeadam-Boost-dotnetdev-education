import React from 'react';

const Footer = () => {
  return (
    <footer className="footer bg-dark text-center">
      <div className="container">
        <span className="text-light">
          &copy; {new Date().getFullYear()} All rights reserved | Oğuzhan KARAGÜZEL
        </span>
      </div>
    </footer>
  );
};

export default Footer;
