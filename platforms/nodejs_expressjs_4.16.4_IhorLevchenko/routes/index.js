var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

router.get('/list', (req, res) => {
  res.render('list', { title: 'Some title', users: [{ id: 1, name: 'name1' }, { id: 2, name: 'name2' }] });
});

module.exports = router;
