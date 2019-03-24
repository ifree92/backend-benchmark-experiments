import { Entity, Column, ManyToOne, PrimaryGeneratedColumn } from 'typeorm';
import { Education } from './education.entity';
import { Gender } from './gender.entity';

@Entity()
export class User {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  firstName: string;

  @Column()
  lastName: string;

  @Column()
  age: number;

  @Column()
  email: string;

  @ManyToOne(type => Education, education => education.users)
  education: Education;

  @ManyToOne(type => Gender, gender => gender.users)
  gender: Gender;
}
