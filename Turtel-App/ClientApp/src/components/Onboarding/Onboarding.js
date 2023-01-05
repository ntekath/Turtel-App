import React from 'react';
import {StyleSheet, View, Text, TextInput, SafeAreaView, Pressable} from 'react-native';
import {InputOutline} from 'react-native-input-outline';
import Camera from '../../images/camera.jsx';
import OwnButton from '../TurtelButton.js';
import OwnCheckButton from '../TurtelCheckButton.js';


export function  Onboarding({ navigation }) {
    return (
        <SafeAreaView style={style.pageStyle}>
            <Pressable>
                <View style={style.imageContainer}>
                    <View style={style.image}><Camera/></View>
                    <Text>Wähle ein Bild von Dir!</Text>
                </View>
            </Pressable>
            <View style={style.inputContainer}>
                <InputOutline placeholder='Name' style={style.input}/>
                <InputOutline placeholder='Geburtstag (TT/MM/JJJJ)' style={style.input}/>
                <View style={style.biological}>
                    <OwnCheckButton name="weiblich"/>
                    <OwnCheckButton name="männlich"/>
                    <OwnCheckButton name="divers"/>
                </View>
                <OwnButton name="Weiter" onPress={() => navigation.navigate(Register)} />
            </View>
        </SafeAreaView>
    );
}

const style = StyleSheet.create ( {
    pageStyle: {
        alignItems: 'center',
        justifyContent: 'center',
        flex: 1,
    },
    input: {
        height: 52,
        width: "90%",
        margin: 12,
        borderWidth: 1,
        borderRadius: 25,
        borderColor: '#000',
        justifyContent: 'center',
        alignSelf: 'center',
    },
    biological: {
        width: '90%',
        flexDirection: 'row',
        marginBottom: 12,
    },
    image: {
        justifyContent: 'center',
        alignSelf: 'center',
        alignItems: 'center',
        borderWidth: 2,
        borderColor: '#9679C1',
        borderRadius: 25,
        width: '60%',
        padding: 5,
        marginBottom: 5
    },
    imageContainer: {
        flex: 0.2,
    },
    inputContainer: {
        flex: 0.5,
        justifyContent: 'center',
        alignItems: 'center'
    }
});