import React, { Component } from 'react';

export class Home extends Component {
  displayName = Home.name

    constructor(props) {
        super(props);
        this.state = { ip: "", loading: true };

        fetch('api/home/userip')
            .then(response => response.json())
            .then(data => {
                this.setState({ ip: data.ip, loading: false });
            });
    }
  render() {
    return (
      <div>
            <h1>MuchLikeMyIP - Just Some Tools</h1>
            <p>Much like your IP is {this.state.ip}</p>
            <p>You can CURL this at api/home/userip </p>
      </div>
    );
  }
}
