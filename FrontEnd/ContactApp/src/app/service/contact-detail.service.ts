import { Injectable } from '@angular/core';
import { ContactDetail } from '../models/contact-detail.model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root',
})
export class ContactDetailService {
  constructor(private httpClient: HttpClient) {}

  readonly baseUrl = 'https://localhost:5001/api/ContactApp';
  formData: ContactDetail = new ContactDetail();
  contactList: ContactDetail[];

  postContactDetails = () => {
    return this.httpClient.post(this.baseUrl, this.formData);
  };

  UpdateContactDetails = () => {
    return this.httpClient.put(
      `${this.baseUrl}/${this.formData.id}`,
      this.formData
    );
  };

  getAllContactDetails = () => {
    this.httpClient
      .get<ContactDetail[]>(this.baseUrl)
      .toPromise()
      .then((res) => {
        this.contactList = res as ContactDetail[];
      });
  };

  deleteContact = (id: number) => {
    return this.httpClient.delete(`${this.baseUrl}/${id}`);
  };
}
