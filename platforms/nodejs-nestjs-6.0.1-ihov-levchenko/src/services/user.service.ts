import { Injectable } from '@nestjs/common';
import { users } from '../data/users';
import { Repository } from 'typeorm';
import { User } from 'src/entities/user.entity';
import { InjectRepository } from '@nestjs/typeorm';
import { Gender } from 'src/entities/gender.entity';
import { Education } from 'src/entities/education.entity';

@Injectable()
export class UserService {
  constructor(
    @InjectRepository(User) private readonly userRepository: Repository<User>,
    @InjectRepository(Gender)
    private readonly genderRepository: Repository<Gender>,
    @InjectRepository(Education)
    private readonly educationRepository: Repository<Education>,
  ) {}
  getMockUsers() {
    return users;
  }

  getUsers() {
    return this.userRepository.find({ relations: ['gender', 'education'] });
  }

  async fillDb() {
    const mockUsers = this.getMockUsers();
    const genders: string[] = [];
    const educations: string[] = [];

    mockUsers.forEach(user => {
      if (genders.indexOf(user.gender) === -1) genders.push(user.gender);
      if (educations.indexOf(user.education) === -1)
        educations.push(user.education);
    });
    const gendersEntities = genders.map(gender => {
      const g = new Gender();
      g.name = gender;
      return g;
    });
    const educationsEntities = educations.map(education => {
      const e = new Education();
      e.name = education;
      return e;
    });
    const usersEntities = mockUsers.map(user => {
      const u = new User();
      u.age = user.age;
      u.email = user.email;
      u.firstName = user.first_name;
      u.lastName = user.last_name;
      u.gender = gendersEntities.find(item => item.name === user.gender);
      u.education = educationsEntities.find(
        item => item.name === user.education,
      );
      return u;
    });
    await this.genderRepository.insert(gendersEntities);
    await this.educationRepository.insert(educationsEntities);
    await this.userRepository.insert(usersEntities);
  }
}
