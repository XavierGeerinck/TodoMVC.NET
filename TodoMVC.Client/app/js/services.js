'use strict';

var services = angular.module('app.services', ['ngResource']);

// Init load the list
services.factory('TodoList', ['$resource',
    function ($resource) {
        return $resource('http://localhost:9000/api/todolist', {}, {
            query: { method: 'GET', params: {}, isArray: true },
            post: {
                method: 'POST',
                transformResponse: function (data, headersGetter) {
                    data = JSON.parse(data);
                    console.log(data["ModelState"]["model.Name"]);
                }
            }
        });
    }
]);