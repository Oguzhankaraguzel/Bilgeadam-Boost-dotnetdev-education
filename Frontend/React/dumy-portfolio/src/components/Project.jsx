import React from "react";
import './css/project.css';

const project = [
    {id:1,name: "E-commerce Website",description:"mükemmel ötesi web sitesi tasarımları"},
    {id:2,name: "Portfolio Website",description:"mükemmel ötesi web sitesi tasarımları"}
]



const Project = () => {
  return (
    <div className="project" id="Project">
      <h2>Project</h2>
      {
        project.map( x => 
            <>
            <h3>Project {x.id}: <small>{x.name}</small></h3>
            <p>{x.description}</p>
            </>
            )
      }
    </div>
  );
};

export default Project;
