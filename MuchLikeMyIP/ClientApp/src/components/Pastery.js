import React, { Component } from 'react';
import AceEditor  from 'react-ace';
import brace from 'brace';
import { render } from 'react-dom';
import 'brace/theme/monokai';
import 'brace/theme/github';


export class Pastery extends Component {
    constructor(props) {
        super(props);

        this.state = {
            value: "",
            theme: 'monokai',
            mode: 'javascript',
            enableBasicAutocompletion: false,
            enableLiveAutocompletion: false,
            fontSize: 14,
            showGutter: true,
            showPrintMargin: true,
            highlightActiveLine: true,
            enableSnippets: false,
            showLineNumbers: true,
        };

        this.onFocus = this.onFocus.bind(this);
    }

    onFocus(e, editor) {
        this.setState({
            theme: "github"
        });
    }

    render() {
        return (
            <div>
                <h1>Pastery in Here</h1>
                <div>
                    <AceEditor
                        theme={this.state.theme}
                        onFocus={this.onFocus}
                    />
                </div>
            </div>
        );
    }
}
