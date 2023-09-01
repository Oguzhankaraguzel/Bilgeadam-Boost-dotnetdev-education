import React from 'react'
import './css/about.css'

const aboutMe = [
    {title:"Background",description:"Lorem ipsum. dolor sit amet"},
    {title:"Education",description:"Lorem ipsum. dolor sit amet"}
]

const About = () => {
  return (
    <div className="about" id='About'>
        <h2>About Me</h2>
        <br />
        {
            aboutMe.map( x => 
                <>
                <h3>{x.title}</h3>
                <p>{x.description}</p>
                </>
                )
        }
    </div>
  )
}

export default About