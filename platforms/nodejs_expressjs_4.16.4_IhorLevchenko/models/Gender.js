const Sequelize = require('sequelize');
const db = require('../db');

class Gender extends Sequelize.Model {}
Gender.init(
  {
    id_gender: {
      type: Sequelize.INTEGER,
      autoIncrement: true,
      primaryKey: true,
    },
    name: Sequelize.STRING,
  },
  {
    sequelize: db.getDb(),
    timestamps: false,
  }
);

module.exports = Gender;
