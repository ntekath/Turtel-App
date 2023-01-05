import React, { Component } from 'react';
import {SafeAreaView, StyleSheet, Text, View, Image} from 'react-native';
import {Register} from './components/Register';
import {PhoneNumber} from './components/PhoneNumber';
import {Onboarding} from './components/Onboarding/Onboarding';

import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';


const Stack = createNativeStackNavigator();

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <NavigationContainer>
        <Stack.Navigator screenOptions={{headerShown: true}}>
          <Stack.Screen name="Register" component={Register} options={{ headerShown: false }}/>
          <Stack.Screen name="PhoneNumber" component={PhoneNumber} options={{ headerShown: false }}/>
          <Stack.Screen name="Onboarding" component={Onboarding} options={{ headerShown: false }}/>
        </Stack.Navigator>
      </NavigationContainer>
    );
  }
   
}

const styles = StyleSheet.create({
  viewAll: {
    marginTop: 35,
    marginLeft: 10,
    marginRight: 10,
    flex: 1,
  }
});
