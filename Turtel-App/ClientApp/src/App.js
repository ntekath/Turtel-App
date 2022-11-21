import React, { Component } from 'react';
import { Route } from 'react-router';
import Register from './components/Register';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Register />
    );
  }
}
