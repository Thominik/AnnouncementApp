export interface Announcement {
    id: number;
    announcementTitle: string;
    industry: string;
    location: string;
    price: number;
    description: string;
    phoneNumber: string;
    skypeNumber: string;
    photoUrl: string;
    firstName: string;
    lastName: string;
    optionalEmail?: string;
}

export interface AnnouncementParams {
    orderBy: string;
    searchTerm?: string;
    cityTerm?: string;
    industryTerm?: string;
    pageNumber: number;
    pageSize: number;
}