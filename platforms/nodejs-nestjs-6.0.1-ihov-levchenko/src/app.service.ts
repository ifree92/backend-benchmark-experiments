import { Injectable } from '@nestjs/common';
import { users } from './data/users';

@Injectable()
export class AppService {
  getMockUsers() {
    return users;
  }
}
