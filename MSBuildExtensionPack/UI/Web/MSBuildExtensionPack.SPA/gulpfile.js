/// <binding BeforeBuild='resx-to-typescript' />
var gulp = require('gulp'),
    gutil = require('gulp-util');

// create a default task and just log a message
gulp.task('resx-to-typescript', function () {
    var resxToTypeScript = require('resx-to-typescript');
    resxToTypeScript.execute('Resources', '../../../../Frameworks/Framework.Resx', '/src/app/localization');
    resxToTypeScript.execute('Resources', '../../../Core/Resx', '/src/app/localization');
});

//gulp.task('clean', function () {
//    //del is an async function and not a gulp plugin (just standard nodejs)
//    //It returns a promise, so make sure you return that from this task function
//    //  so gulp knows when the delete is complete
//    return gutil.log('Gulp is running!')
//});

//var gulp = require("gulp");
//var resxToTypeScript = require('resx-to-typescript');
//gulp.task("resx-to-typescript-task", function () {
//    resxToTypeScript.execute('exampleApp.resources', '/Resources', '/App/Resources');
//});
