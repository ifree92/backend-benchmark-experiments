const User = require('./User');
const Education = require('./Education');
const Gender = require('./Gender');

Gender.hasMany(User);
Education.hasMany(User);

User.belongsTo(Gender);
User.belongsTo(Education);
