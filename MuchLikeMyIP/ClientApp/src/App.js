import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Pastery } from './components/Pastery';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Route exact path='/pastery' component={Pastery} />
      </Layout>
    );
  }
}
