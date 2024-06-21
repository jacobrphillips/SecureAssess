import { Company } from './company';
import { Photo } from './photo';

export interface Member {
  id: number;
  emailAddress: string;
  firstName: string;
  lastName: string;
  fullName: string;
  photoUrl: string;
  created: string;
  lastActive: string;
  photo: Photo;
  companies: Company[];
}
