var express = require('express');
var router = express.Router();
var users = require('../data/users');

router.get('/', (req, res) => {
  res.render('users', { users });
});

module.exports = router;
