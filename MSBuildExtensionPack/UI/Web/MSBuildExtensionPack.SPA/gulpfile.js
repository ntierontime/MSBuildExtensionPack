var gulp = require("gulp");
var resxToTypeScript = require('resx-to-typescript');
gulp.task("resx-to-typescript-task", function () {
    resxToTypeScript.execute('exampleApp.resources', '/Resources', '/App/Resources');
});
