import React, { Component } from 'react';
import {StyleSheet, View, Text, Image, Pressable} from 'react-native';
import logo from '../images/logo-png.png';
import taube_left from '../images/taube_register_left_png.png';
import taube_right from '../images/taube_register_right_png.png';
import OwnButton from './Button.js';

export default class Register extends Component {

    render() {
        return (
            <View style={style.contentRegister}>
                <Image source={logo} style={style.logoRegister}/>
                <View style={style.tauben}>
                    <Image source={taube_left} style={style.taubeLeft}/>
                    <Image source={taube_right} style={style.taubeRight}/>
                </View>
                <View style={style.signin}>
                <OwnButton name="Registrieren" style={style.registerButton}/>
                    <Text style={style.signinRegisterText}>Du bist schon registriert?</Text>
                    <Pressable style={style.signinButton}>
                        <Text style={style.signinButtonText}>Anmelden</Text>
                    </Pressable>
                </View>
            </View>
        );
    }
}

const style = StyleSheet.create ( {
    contentRegister: {
        flex: 1,
        alignItems: 'center',
    },
    logoRegister: {
        marginTop: 100,
        alignContent: 'center',
    },
    tauben: {
        flexDirection: 'row',
        flex: 1,
        justifyContent: 'center',
        top: 50,
    },
    taubeLeft: {
        left: -5,
    }, 
    taubeRight: {
        right: -10,
        marginTop: -25,
    },
    signin: {
        textAlign: 'center',
        marginBottom: 100,
        position: 'absolute',
        bottom: 0,
    },
    signinRegisterText: {
        textAlign: 'center',
        fontSize: 16,
        marginTop: 20,
    },  
    signinButtonText: {
        color: '#5BCDBF',
        textAlign: 'center',
        fontSize: 16,
        padding: 10,
    },
});