import React, { Component } from 'react';
import logo from '../images/logo2.svg';
import taube_left from '../images/taube_register_left.svg';
import taube_right from '../images/taube_register_right.svg';
import './Register.css';


export default class Register extends Component {

    render() {
        return (
            <div class="RegisterScreen">
                <img class="RegisterLogo" src={logo} alt="logo" />
                <div class="TaubenRegister">
                    <img id="taubeLeft" src={taube_left} alt="taube_left" />
                    <img id="taubeRight" src={taube_right} alt="taube_left" />
                </div>
                <div class="RegisterButton">
                    <a class="RegisterButtonText" href="">Registrieren</a>
                </div>
                <div class="SignIn">
                    Du bist schon registriert? <br />
                    <a class="SignInLogin" href="">Anmelden</a>
                </div>
            </div>
        );
    }
}