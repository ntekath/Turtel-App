import React from 'react';
import {StyleSheet, SafeAreaView, View, Text, Image, Pressable} from 'react-native';
import Logo from '../images/logo.jsx';
import TaubeLeftSVG from '../images/taube_left.jsx';
import TaubeRightSVG from '../images/taube_right.jsx';
import OwnButton from './TurtelButton';
import {PhoneNumber} from './PhoneNumber';

export function Register({navigation}) {
    return (
        <SafeAreaView style={style.contentRegister}>
           <View style={style.logoRegister}>
                <Logo />
           </View>
            <View style={style.tauben}>
                <TaubeLeftSVG />
                <TaubeRightSVG />
            </View>
            <View style={style.signin}>
            <OwnButton name="Registrieren" style={style.registerButton} onPress={() => navigation.navigate(PhoneNumber)}/>
                <Text style={style.signinRegisterText}>Du bist schon registriert?</Text>
                <Pressable style={style.signinButton}>
                    <Text style={style.signinButtonText}>Anmelden</Text>
                </Pressable>
            </View>
        </SafeAreaView>
    );
}

const style = StyleSheet.create ( {
    contentRegister: {
        flex: 1,
        top: '5%',
        justifyContent: 'center',
        alignItems: 'center',
    },
    logoRegister: {
        marginTop: "10%",
        alignContent: 'center',
    },
    tauben: {
        alignItems: 'center',
        flex: 1,
        flexDirection: 'row',
    },
    signin: {
        textAlign: 'center',
        marginBottom: "10%",
        justifyContent: 'center',
        flex: 1,
    },
    signinRegisterText: {
        textAlign: 'center',
        fontSize: 16,
        marginTop: 20,
        color: '#4C4C4C',
    },  
    signinButtonText: {
        color: '#5BCDBF',
        textAlign: 'center',
        fontSize: 16,
        padding: 10,
    },
});