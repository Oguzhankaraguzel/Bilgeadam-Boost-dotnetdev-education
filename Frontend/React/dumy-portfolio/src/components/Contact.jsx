import React from 'react'
import './css/contact.css'

const Contact = () => {
  return (
    <div id='Contact'>
      <form className='contact' action="#">
        <h2>Contact</h2>
        <label htmlFor="Name">Name:</label>
        <input type="text" name="" id="Name" />
        <label htmlFor="Email">Email:</label>
        <input type="Email" name="" id="Email" />
        <label htmlFor="Message">Message:</label>
        <textarea name="" id="Message" cols="30" rows="10"></textarea>
        <button type="submit" className='btn1'>Send</button>
        </form>
    </div>
  )
}

export default Contact