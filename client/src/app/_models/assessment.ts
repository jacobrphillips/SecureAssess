import { Member } from './member';

export interface Assessment {
  id: number;
  name: string;
  startDate: string;
  endDate: string;
  assessmentType: string;
  assessor: Member;
}
