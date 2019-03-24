const User = require('../models/User');
const Gender = require('../models/Gender');
const Education = require('../models/Education');
const mockUsers = require('../data/users');

async function fill() {
  const genders = [];
  const educations = [];
  mockUsers.forEach((user) => {
    if (genders.indexOf(user.gender) === -1) genders.push(user.gender);
    if (educations.indexOf(user.education) === -1) educations.push(user.education);
  });
  const genderModels = await Gender.bulkCreate(genders.map((item) => ({ name: item })));
  const educationModels = await Education.bulkCreate(educations.map((item) => ({ name: item })));
  await User.bulkCreate(
    mockUsers.map((user) => {
      return {
        first_name: user.first_name,
        last_name: user.last_name,
        age: user.age,
        email: user.email,
        phone: user.phone,
        EducationIdEducation: educationModels.find((item) => item.get().name === user.education).get().id_education,
        GenderIdGender: genderModels.find((item) => item.get().name === user.gender).get().id_gender,
      };
    })
  );
}

module.exports = {
  fill,
};
