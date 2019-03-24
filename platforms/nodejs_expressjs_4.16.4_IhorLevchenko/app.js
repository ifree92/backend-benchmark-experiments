var express = require('express');
var path = require('path');
var logger = require('morgan');
var { isDev } = require('./helpers/env');

var indexRouter = require('./routes/index');
const DB = require('./db');
require('./models/associations');

async function main() {
  const app = express();
  // express settings
  app.set('views', path.join(__dirname, 'views'));
  app.set('view engine', 'hbs');

  // logging
  if (isDev()) {
    console.log('* Development mode');
    app.use(logger('dev'));
  }
  // middleware
  app.use(express.json());
  app.use(express.urlencoded({ extended: false }));
  app.use(express.static(path.join(__dirname, 'public')));
  app.use('/', indexRouter);

  await DB.sync();
  app.listen(4000);
  console.log('* Listening on 4000');
}

main()
  .then(() => {})
  .catch((err) => console.error(err));

// module.exports = app;
