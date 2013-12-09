'use strict';

var services = angular.module('app.services', ['ngResource']);

// Init load the list
services.factory('TodoListFactory', ['$resource',
    function ($resource) {
        return $resource('http://localhost:9000/api/todolist/:id', {}, {
            query: { method: 'GET', params: {}, isArray: true },
            add: { method: 'POST' },
            remove: { method: 'DELETE' },
            edit: { method: 'PUT' }
        });
    }
]);