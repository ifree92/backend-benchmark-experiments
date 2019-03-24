const Sequelize = require('sequelize');

class DB {
  constructor() {
    this._db = new Sequelize('mydb', 'root', '', {
      dialect: 'mysql',
      // sync: { force: true },
      // logging: false,
    });
  }

  sync() {
    return this._db.sync();
  }

  getDb() {
    return this._db;
  }
}

module.exports = new DB();
