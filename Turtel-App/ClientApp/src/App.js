import React, { Component } from 'react';
import {StyleSheet, Text, View} from 'react-native';
import { Route } from 'react-router';
import Register from './components/Register';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <View style={styles.viewAll}>
          <Register />
        </View>
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
