import { Controller, Get, Render, Post } from '@nestjs/common';
import { UserService } from '../services/user.service';

@Controller()
export class AppController {
  constructor(private readonly userService: UserService) {}

  @Get('/empty')
  async getEmpty() {}

  @Get('/mock-users')
  @Render('users.hbs')
  getMockUsers() {
    return { users: this.userService.getMockUsers() };
  }

  @Get('db-users')
  @Render('db-users.hbs')
  async getDbUsers() {
    return { users: await this.userService.getUsers() };
  }

  @Post('fill-db')
  async postFillDb() {
    await this.userService.fillDb();
  }
}
