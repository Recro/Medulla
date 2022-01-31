const autoprefixer = require('autoprefixer')
const sass = require('@koddsson/postcss-sass')
const scss = require('postcss-scss')
const scssImport = require('postcss-import')
const {join} = require('path')

module.exports = {
    map: {
        sourceContent: false,
        annotation: true
    },
    customSyntax: scss,
    parser: scss,
    plugins: [
        scssImport,
        sass({
            includePaths: [join(__dirname, 'node_modules')],
            outputStyle: 'compressed'
        }),
        autoprefixer
    ]
}
