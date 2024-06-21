import { Certificate } from './certificate';
import { Contact } from './contact';

export interface Company {
  id: number;
  name: string;
  city: string;
  country: string;
  contacts: Contact[];
  assessments: any[];
  certificates: Certificate[];
  vulnerabilityReports: any[];
}
