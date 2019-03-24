import { Module } from '@nestjs/common';
import { AppController } from './controllers/app.controller';
import { TypeOrmModule } from '@nestjs/typeorm';
import { UserService } from './services/user.service';
import { User } from './entities/user.entity';
import { Gender } from './entities/gender.entity';
import { Education } from './entities/education.entity';

@Module({
  imports: [
    TypeOrmModule.forRoot({
      type: 'mysql',
      host: 'localhost',
      port: 3306,
      username: 'root',
      password: '',
      database: 'mydb',
      entities: [__dirname + '/**/*.entity{.ts,.js}'],
      synchronize: true,
      entityPrefix: 'nestjs_',
    }),
    TypeOrmModule.forFeature([User, Gender, Education]),
  ],
  controllers: [AppController],
  providers: [UserService],
})
export class AppModule {}
