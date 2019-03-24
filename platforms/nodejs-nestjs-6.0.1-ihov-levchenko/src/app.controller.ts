import { Controller, Get, Render } from '@nestjs/common';
import { AppService } from './app.service';

@Controller()
export class AppController {
  constructor(private readonly appService: AppService) {}

  @Get('/empty')
  getEmpty() {}

  @Get('/mock-users')
  @Render('users.hbs')
  getNew() {
    return { users: this.appService.getMockUsers() };
  }
}
