/// <binding BeforeBuild='Run - Development' />
"use strict";
const path = require('path');

module.exports = {
    entry: "./main.ts",
    output: {
        path: path.resolve('./dist'),
        filename: "[name].bundle.js"
    },
    resolve: {
        extensions: ['.ts', '.js', '.html']
    },
    module: {
        rules: [
            { test: /\.html$/, loader: 'raw-loader' },
            { test: /\.css/, loader: 'raw-loader' },
            { test: /\.ts/, loader: ['awesome-typescript-loader', 'angular2-template-loader'] },
        ]
    },
    devtool: '#source-map'
};