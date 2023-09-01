import React from "react";
import "./css/skills.css";

const skills = [
  {
    name: "HTML",
    description:
      "Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestiae ducimus voluptates fuga nobis deleniti culpa maiores ullam",
  },
  {
    name: "JavaScript",
    description:
      "Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestiae ducimus voluptates fuga nobis deleniti culpa maiores ullam",
  },
  {
    name: "CSS",
    description:
      "Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestiae ducimus voluptates fuga nobis deleniti culpa maiores ullam",
  },
  {
    name: "Responsive Desing",
    description:
      "Lorem ipsum dolor sit amet consectetur adipisicing elit. Molestiae ducimus voluptates fuga nobis deleniti culpa maiores ullam",
  },
];

const Skills = () => {
  return (
    <div className="skills" id="Skills">
      <h2>Skills</h2>
      {
        <ul>{
          skills.map( x =>
          <li>
            <h3>{x.name}</h3>
            <p>{x.description}</p>
          </li>
          )
        }
        </ul>
      }
    </div>
  );
};

export default Skills;
