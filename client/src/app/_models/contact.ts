import { Photo } from './photo';

export interface Contact {
  id: number;
  emailAddress: string;
  firstName: string;
  lastName: string;
  photoUrl: string;
  created: string;
  lastActive: string;
  photo: Photo;
  companies: any;
}
