const Sequelize = require('sequelize');
const db = require('../db');

class Education extends Sequelize.Model {}
Education.init(
  {
    id_education: {
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

module.exports = Education;
