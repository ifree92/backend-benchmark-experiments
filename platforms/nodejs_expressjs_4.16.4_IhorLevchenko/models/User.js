const Sequelize = require('sequelize');
const db = require('../db');

class User extends Sequelize.Model {}
User.init(
  {
    id_user: {
      type: Sequelize.INTEGER,
      autoIncrement: true,
      primaryKey: true,
    },
    first_name: Sequelize.STRING,
    last_name: Sequelize.STRING,
    age: Sequelize.INTEGER,
    email: Sequelize.STRING,
    phone: Sequelize.STRING,
  },
  {
    sequelize: db.getDb(),
    timestamps: false,
  }
);

module.exports = User;
