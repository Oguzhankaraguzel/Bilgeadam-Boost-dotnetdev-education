import React from "react";
import './css/profile.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTwitter, faInstagram, faLinkedin, faGithub, faFacebook } from '@fortawesome/free-brands-svg-icons';

const buttons = [ 
  {name: "Twitter", icon: faTwitter},
  {name: "Instagram", icon: faInstagram},
  {name: "Linkedin", icon: faLinkedin},
  {name: "Github", icon: faGithub},
  {name: "Facebook", icon: faFacebook}
];

const Profile = () => {
  return (
    <div className="Profile">
      <h1>Welcome To My Website</h1>
      <br />
      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique voluptatibus necessitatibus a animi, dignissimos sapiente ut illo laudantium dolorum rem dolores eveniet ad exercitationem explicabo! Corporis perferendis quidem eius suscipit.</p>
      <br />
      <img className="pp" src="https://cdn.rockettstgeorge.co.uk/media/catalog/product/cache/da0750d9711af85067dbdd1214db665f/o/s/ostrich-canvas-by-angela-rossi.jpg" alt="mrs. Ostrich" srcSet="" />
      <br />
      <br />
      {buttons.map((x) => (
          <a href="#">
            <FontAwesomeIcon icon={x.icon} />
          </a>
      ))}
    </div>
  );
};

export default Profile;
