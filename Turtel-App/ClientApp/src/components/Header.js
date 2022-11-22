import React,{Component} from 'react';
import './Header.css';
import logo from '../images/logo2.svg';
import help from '../images/taube_help.svg';


export class Header extends Component {
    
    render () {
      return (
        <header className='header'>
            <img src={logo} alt='logo' id='logo'/>
            <a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ"><img src={help} alt='help' id='help'/></a>
        </header>
      );
    }
  }
  