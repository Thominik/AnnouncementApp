import {configureStore} from "@reduxjs/toolkit";
import {catalogSlice} from "../features/announcements/announcementSlice";
import {TypedUseSelectorHook, useDispatch, useSelector} from "react-redux";
import {accountSlice} from "../features/account/accountSlice";

export const store = configureStore({
    reducer: {
        catalog: catalogSlice.reducer,
        account: accountSlice.reducer
    }
})

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;