module.exports = function(grunt) {
    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
		connect: {
			server: {
				options: {
					port: 8080,
					base: './TodoMVC.Client/app',
					keepalive: true
				}
			}
		}
    });
  
    grunt.loadNpmTasks('grunt-contrib-connect');
	
    // Run the default task
    grunt.registerTask('default', ['connect']);
};