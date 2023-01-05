import React, {useState} from 'react';
import {StyleSheet, View, Text, TextInput, SafeAreaView} from 'react-native';
import {InputOutline} from 'react-native-input-outline';
import OwnButton from './TurtelButton.js';
import DropDownPicker from 'react-native-dropdown-picker';
import {Onboarding} from './Onboarding/Onboarding';

export function  PhoneNumber({ navigation }) {
    const [open, setOpen] = useState(false);
    const [value, setValue] = useState(null);
    const [items, setItems] = useState([
        {label: 'Dänemark (+45)', value: '+45'},
        {label: 'Deutschland (+49)', value: '+49'},
        
    ]);

    return (
        <SafeAreaView style={style.phoneNumberPageStyle}>
            <DropDownPicker 
                placeholder='Vorwahl'
                open={open}
                dropDownContainerStyle={style.containerStyle}
                value={value}
                items={items}
                setOpen={setOpen}
                setValue={setValue}
                setItems={setItems}
                style={style.input}
            />
            <InputOutline placeholder='Handynummer' style={style.input}/>
            <Text style={style.textStyle}>Wir brauchen Deine Telefonnummer, um dich anzumelden.</Text>
            <OwnButton name="Weiter" onPress={() => navigation.navigate(Onboarding)} />
        </SafeAreaView>
        
    );
}

const style = StyleSheet.create ( {
    phoneNumberPageStyle: {
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
    containerStyle: {
        width: "90%",
        justifyContent: 'center',
        alignSelf: 'center',
    },
    textStyle: {
        textAlign: 'center',
        margin: 20,
        color: '#4C4C4C',
    }
});