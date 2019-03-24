const express = require('express');
const router = express.Router();
const users = require('../data/users');
const Education = require('../models/Education');
const Gender = require('../models/Gender');
const User = require('../models/User');
const dbFillerService = require('../services/db-filler');

router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

router.get('/empty', (req, res) => {
  res.send();
});

router.get('/mock-users', (req, res) => {
  res.render('users', { users });
});

router.post('/fill-db', (req, res) => {
  dbFillerService.fill().then(() => res.send('ok'));
});

router.get('/db-users', (req, res) => {
  User.findAll({ include: [{ model: Education }, { model: Gender }] }).then((users) => {
    res.render('db-users', { users });
  });
});

module.exports = router;
