var express = require('express');
var router = express.Router();
var users = require('../data/users');

router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

router.get('/empty', (req, res) => {
  res.send();
});

router.get('/mock-users', (req, res) => {
  res.render('users', { users });
})

module.exports = router;
