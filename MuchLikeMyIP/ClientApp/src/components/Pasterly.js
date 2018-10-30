import React, { Component } from 'react';

export class Pasterly extends Component {
    constructor(props) {
        super(props);
        this.state = {
            value: 'Pasterly here'
        };

        this.handleChange = this.handleChange.bind(this);
    }

    handleChange(event) {
        this.setState({ value: event.target.value });
    }


    render() {
        return (
            <div>
            <h1> Pasterly for text</h1>
            <div>
                <form>
                    <textarea value={this.state.value} onChange={this.handleChange} />
                </form>
                </div>
                </div>
        );
        
    }
};